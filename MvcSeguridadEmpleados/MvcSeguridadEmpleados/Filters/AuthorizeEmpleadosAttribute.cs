﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MvcSeguridadEmpleados.Filters
{
    public class AuthorizeEmpleadosAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
            //context.HttpContext.Session.SetString("CONTROLLER", controller);
            //context.HttpContext.Session.SetString("ACTION", action);
            //context.HttpContext.Response.Cookies.Append("routedata", controller + "," + action);
            var user = context.HttpContext.User;
            if (user.Identity.IsAuthenticated == false)
            {
                string controller = context.RouteData.Values["controller"].ToString();
                string action = context.RouteData.Values["action"].ToString();
                ITempDataProvider provider = context.HttpContext.RequestServices.GetService(typeof(ITempDataProvider)) as ITempDataProvider;
                var TempData = provider.LoadTempData(context.HttpContext);
                TempData["controller"] = controller;
                TempData["action"] = action;
                provider.SaveTempData(context.HttpContext, TempData);
                context.Result = this.GetRouteRedirect("Manage", "LogIn");
            }
            else
            {
                //EL USUARIO EXISTE DEBEMOS VALIDAR SU ROLE CON OFICIO
                if (user.IsInRole("PRESIDENTE")==false
                    && user.IsInRole("DIRECTOR")==false
                    && user.IsInRole("ANALISTA") == false)
                {
                    context.Result = this.GetRouteRedirect("Manage", "ErrorAcceso");
                }
            }
        }

        private RedirectToRouteResult GetRouteRedirect(string controller, string action)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(new
            {
                controller=controller,
                action=action
            });
            RedirectToRouteResult result = new RedirectToRouteResult(ruta);
            return result;
        }
    }
}
