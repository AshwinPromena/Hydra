﻿using Hydra.BusinessLayer.ActionFilters;
using Hydra.BusinessLayer.Concrete.IService.IStaffService;
using Hydra.Common.Globle;
using Hydra.Common.Globle.Enum;
using Hydra.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hydra.Controllers.StaffController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StaffController(IStaffService staffService) : ControllerBase
    {
        private readonly IStaffService _staffService = staffService;

        [HttpPost("[action]"), Authorize(Roles = "Admin")]
        [CustomAuthorizationFilterAttributeFilterFactory((int)AccessLevelType.ViewEditAndDelete, [(int)Roles.Admin])]
        public async Task<ApiResponse> AddStaff(AddStaffModel model)
        {
            if (!ModelState.IsValid)
                return new(400, ResponseConstants.BadRequest);

            return await _staffService.AddStaff(model);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin")]
        [CustomAuthorizationFilterAttributeFilterFactory((int)AccessLevelType.ViewEditAndDelete, [(int)Roles.Admin])]
        public async Task<ApiResponse> UpdateStaff(UpdateStaffModel model)
        {
            if (!ModelState.IsValid)
                return new(400, ResponseConstants.BadRequest);

            return await _staffService.UpdateStaff(model);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin")]
        [CustomAuthorizationFilterAttributeFilterFactory((int)AccessLevelType.ViewEditAndDelete, [(int)Roles.Admin])]
        public async Task<ApiResponse> DeleteStaff(DeleteStaffModel model)
        {
            if (!ModelState.IsValid)
                return new(400, ResponseConstants.BadRequest);

            return await _staffService.DeleteStaff(model);
        }

        [HttpPost("[action]")]
        public async Task<ApiResponse> ArchivedStaffs(DeleteStaffModel model)
        {
            if (!ModelState.IsValid)
                return new(400, ResponseConstants.BadRequest);

            return await _staffService.ArchivedStaffs(model);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin")]
        public async Task<ServiceResponse<GetStaffModel>> GetStaffById(long userId)
        {
            if (!ModelState.IsValid)
                return new(400, ResponseConstants.BadRequest);

            return await _staffService.GetStaffById(userId);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin")]
        [CustomAuthorizationFilterAttributeFilterFactory((int)AccessLevelType.ViewEditAndDelete, [(int)Roles.Admin])]
        public async Task<PagedResponse<List<GetStaffModel>>> GetAllStaff(PagedResponseInput model, bool isArchived)
        {
            if (!ModelState.IsValid)
                return new() { StatusCode = 400, Message = ResponseConstants.BadRequest };

            return await _staffService.GetAllStaff(model, isArchived);
        }

        [HttpGet("[action]"), Authorize(Roles = "Admin")]
        [CustomAuthorizationFilterAttributeFilterFactory((int)AccessLevelType.ViewEditAndDelete, [(int)Roles.Admin])]
        public async Task<ApiResponse> ApproveStaffUser(long staffUserId)
        {
            return await _staffService.ApproveStaffUser(staffUserId);
        }

        [HttpPost("[action]"), Authorize(Roles = "Admin")]
        [CustomAuthorizationFilterAttributeFilterFactory((int)AccessLevelType.ViewEditAndDelete, [(int)Roles.Admin])]
        public async Task<ApiResponse> ApproveBadge(ApproveBadgeModel model)
        {
            if (!ModelState.IsValid)
                return new(400, ResponseConstants.BadRequest);

            return await _staffService.ApproveBadge(model);
        }

    }
}
