﻿using SoftwareHouse.Contract.DataContracts;
using System.Collections.Generic;

namespace SoftwareHouse.Contract.Interfaces
{
    public interface IProjectsRepository
    {
        List<ProjectDto> GetAll();
        ProjectDto GetByName(string projectName);
        void Add(ProjectDto project);
    }
}