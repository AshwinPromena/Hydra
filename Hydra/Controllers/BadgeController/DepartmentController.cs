﻿using Hydra.BusinessLayer.Concrete.IService.IBadgeService;
using Hydra.Common.Globle;
using Hydra.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hydra.Controllers.BadgeController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentServices departmentServices) : ControllerBase
    {
        private readonly IDepartmentServices _departmentServices = departmentServices;

        [HttpPost("[action]"), Authorize(Roles = "Admin , Staff , UniversityAdmin")]
        public async Task<ServiceResponse<DepartmentIDModel>> AddDepartment(string departmentName)
        {
            if (!ModelState.IsValid)
                return new (400, ResponseConstants.BadRequest, null);

            return await _departmentServices.AddDepartment(departmentName);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin , Staff , UniversityAdmin")]
        public async Task<ApiResponse> UpdateDepartment(int departmentId, string departmentName)
        {
            if (!ModelState.IsValid)
                return new ApiResponse(400, ResponseConstants.BadRequest);

            return await _departmentServices.UpdateDepartment(departmentId, departmentName);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin , Staff , UniversityAdmin")]
        public async Task<ApiResponse> DeleteDepartment(int departmentId)
        {
            if (!ModelState.IsValid)
                return new ApiResponse(400, ResponseConstants.BadRequest);

            return await _departmentServices.DeleteDepartment(departmentId);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin , Staff , UniversityAdmin")]
        public async Task<ServiceResponse<DepartmentOutputModel>> GetDepartmentById(long departmentId)
        {
            if (!ModelState.IsValid)
                return new ServiceResponse<DepartmentOutputModel>(400, ResponseConstants.BadRequest, null);

            return await _departmentServices.GetDepartmentById(departmentId);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin , Staff , UniversityAdmin")]
        public async Task<PagedResponse<List<DepartmentOutputModel>>> GetAllDepartments(PagedResponseInput model)
        {
            if (!ModelState.IsValid)
                return new() { StatusCode = 400, Message = ResponseConstants.BadRequest };

            return await _departmentServices.GetAllDepartments(model);
        }

    }
}
