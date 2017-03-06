using MountainBlog.Common.Mapping;
using MountainBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MountainBlog.ViewModels
{
    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}