﻿using DagusBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagusBlog.Services.Contracts
{
   public  interface IPostService : IService<Post>
    {
        IQueryable<Post> GetAll();
            
    }
}
