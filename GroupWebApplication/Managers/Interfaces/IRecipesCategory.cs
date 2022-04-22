﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupWebApplication.Models;

namespace GroupWebApplication.Managers.Interfaces
{
    public interface IRecipesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
