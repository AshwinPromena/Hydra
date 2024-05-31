﻿using Hydra.Common.Models;
namespace Hydra.BusinessLayer.Repository.IService.IDropDownService
{
    public interface IDropDownService
    {
        Task<ServiceResponse<List<DepartmentDropDownModel>>> GetAllDepartment();

        Task<ServiceResponse<List<AccessLevelDropDownModel>>> GetAllAccessLevel();

        Task<ServiceResponse<List<UserDropDownModel>>> GetAllApprovalUsers();

        Task<PagedResponse<List<UserDropDownModel>>> GetLearnersForBadgeAssign(PagedResponseInput model, long? badgeId = null);

        Task<PagedResponse<List<BadgeDropDownModel>>> GetBadgesToAssignLearner(PagedResponseInput model, long? userId = null);

        ServiceResponse<List<BadgeSortByDropDownModel>> GetBadgeSortOptions();
    }
}
