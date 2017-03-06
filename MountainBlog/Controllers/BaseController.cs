using AutoMapper;
using MountainBlog.Common.Mapping;
using MountainBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MountainBlog.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController(): this(new MountainBlogData())
        {

        }

        public BaseController(IMountainBlogData data)
        {
            this.Data = data;
        }

        protected IMountainBlogData Data{ get; private set; }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}