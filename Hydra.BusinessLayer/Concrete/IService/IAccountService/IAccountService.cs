﻿using Hydra.Common.Models;

namespace Hydra.BusinessLayer.Repository.IService.IAccountService
{
    public interface IAccountService
    {
        Task<ApiResponse> Register(UserRegisterModel model);

        Task<ServiceResponse<LoginResponse>> Login(LoginModel model);

        Task<ApiResponse> ForgotPassword(ForgotPasswordModel model);

        Task<ApiResponse> ResetPassword(ResetPasswordModel model);

        Task<ApiResponse> ReSendOtp(ForgotPasswordModel model);
    }
}
