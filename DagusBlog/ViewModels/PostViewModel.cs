﻿using DagusBlog.Common.Mapping;
using DagusBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagusBlog.ViewModels
{
   
    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string SubHeader { get; set; }

        public ApplicationUserViewModel Author { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}