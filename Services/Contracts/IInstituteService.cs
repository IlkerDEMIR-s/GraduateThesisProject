﻿using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IInstituteService
    {
        IEnumerable<Institute> GetAllInstitutes(bool trackChanges);
        Institute? GetOneInstitute(int id, bool trackChanges);
        void CreateInstitute(Institute institute);
        void DeleteOneInstitute(int id);
        void DeleteInstitutesByUniversityId(int id);
}
}
