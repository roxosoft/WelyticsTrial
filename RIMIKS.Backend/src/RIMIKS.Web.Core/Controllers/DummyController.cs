using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Abp.MultiTenancy;
using Microsoft.Extensions.Primitives;
using RIMIKS.Authentication.External;
using RIMIKS.Authentication.JwtBearer;
using RIMIKS.Authorization;
using RIMIKS.Authorization.Users;
using RIMIKS.Models.TokenAuth;

namespace RIMIKS.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DummyController : RIMIKSControllerBase
    {
        public class DummyDto
        {
            public string Risk { get; set; }
            public string Category { get; set; } 
            public string AreaOfRisk { get; set; }
            public int Relevance { get; set; }
            public string Owner { get; set; }
            public int Year { get; set; }
        }
        
        private readonly LogInManager _logInManager;
        private readonly ITenantCache _tenantCache;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly TokenAuthConfiguration _configuration;
        private readonly IExternalAuthConfiguration _externalAuthConfiguration;
        private readonly IExternalAuthManager _externalAuthManager;
        private readonly UserRegistrationManager _userRegistrationManager;

        public DummyController(
            LogInManager logInManager,
            ITenantCache tenantCache,
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            TokenAuthConfiguration configuration,
            IExternalAuthConfiguration externalAuthConfiguration,
            IExternalAuthManager externalAuthManager,
            UserRegistrationManager userRegistrationManager)
        {
            _logInManager = logInManager;
            _tenantCache = tenantCache;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _configuration = configuration;
            _externalAuthConfiguration = externalAuthConfiguration;
            _externalAuthManager = externalAuthManager;
            _userRegistrationManager = userRegistrationManager;
        }

        [HttpGet]
        public List<DummyDto> GetData()
        {
            string lang = "";
            
            if (HttpContext.Request.Headers.TryGetValue(".AspNetCore.Culture", out StringValues culture))
            {
                if (culture.Count > 0)
                {
                    lang = culture[0];
                }
            }

            switch (lang.ToLowerInvariant())
            {
                case "de":
                    return new List<DummyDto>
                    {
                        new DummyDto
                        {
                            Risk = "Risiko1",
                            Category = "Kategorie1",
                            AreaOfRisk = "Risikofeld1",
                            Relevance = 1,
                            Owner = "Eigentümer1",
                            Year = 2001
                        },
                        new DummyDto
                        {
                            Risk = "Risiko2",
                            Category = "Kategorie2",
                            AreaOfRisk = "Risikofeld2",
                            Relevance = 2,
                            Owner = "Eigentümer2",
                            Year = 2002
                        },
                        new DummyDto
                        {
                            Risk = "Risiko3",
                            Category = "Kategorie3",
                            AreaOfRisk = "Risikofeld3",
                            Relevance = 3,
                            Owner = "Eigentümer3",
                            Year = 2003
                        },
                    };
                
                default:
                    return new List<DummyDto>
                    {
                        new DummyDto
                        {
                            Risk = "Risk1",
                            Category = "Category1",
                            AreaOfRisk = "AreaOfRisk1",
                            Relevance = 1,
                            Owner = "Owner1",
                            Year = 2001
                        },
                        new DummyDto
                        {
                            Risk = "Risk2",
                            Category = "Category2",
                            AreaOfRisk = "AreaOfRisk2",
                            Relevance = 2,
                            Owner = "Owner2",
                            Year = 2002
                        },
                        new DummyDto
                        {
                            Risk = "Risk3",
                            Category = "Category3",
                            AreaOfRisk = "AreaOfRisk3",
                            Relevance = 3,
                            Owner = "Owner3",
                            Year = 2003
                        },
                    };
            }
        }
    }
}
