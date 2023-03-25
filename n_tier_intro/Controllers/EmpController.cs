﻿using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n_tier_intro.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage Get()
        {
            try
            {
               return Request.CreateResponse(HttpStatusCode.OK,EmployeeService.Get());
            }
            catch(Exception ex)
            {
               return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
