using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;


namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }

        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }


        public AddJobViewModel()
        {
            //Eventually add this one but It wouldn't be empty and it would be an AddJobViewModel constructor
        }
    }



}



