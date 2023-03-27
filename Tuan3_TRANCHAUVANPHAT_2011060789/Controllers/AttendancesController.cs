using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Tuan3_TRANCHAUVANPHAT_2011060789.Migrations;
using Tuan3_TRANCHAUVANPHAT_2011060789.Models;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Tuan3_TRANCHAUVANPHAT_2011060789.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
       
    }
}
