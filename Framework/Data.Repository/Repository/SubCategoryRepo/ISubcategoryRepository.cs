﻿using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Repository.SubCategoryRepo
{
    public interface ISubcategoryRepository
    {
        SubCategory GetSubCategory(int id);

        List<SubCategory> GetAllSubCategories();

        void AddSubCategory(SubCategory subCategory);

        void UpdateSubCategory(SubCategory subCategory);
    }
}
