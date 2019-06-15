using System;
using System.Threading.Tasks;
using GFDT.Models.Request;
using GFDT.Models.Response;
using GFTD.Models.Request;
using GFTD.Models.Response;

namespace GFDT.Managers.UserManager
{
    public interface IUserManager
    {


        #region All Response
        LoginResponse LoginResponse { get; }
        CompleteProfileResponse CompleteProfileResponse { get; }
        SignupResponse SignupResponse { get; }
        ResetPasswordResponse ResetPasswordResponse { get; }
        OTPVerificationResponse OTPVerificationResponse { get; }
        BankResponse BankResponse { get; }
        GetListItemResponce GetListItemResponce { get; }
        BaseResponseModel AddItemResponse { get; }
        BaseResponseModel ContactUsResponse { get; }
        BaseResponseModel SendGiftResponse { get; }
        GetListResponse GetListResponse { get; }
        #endregion

        #region ALL API

        void Login(LoginRequest loginRequest, Action success, Action<BaseResponseModel> failed);

        void Signup(SignupRequest signupRequest, Action success, Action<BaseResponseModel> failed);

        void CompleteProfile(CompleteProfileRequest completeProfileRequest, Action success, Action<BaseResponseModel> failed);

        void OTPVerification(OTPVerificationRequest oTPVerificationRequest, Action success, Action<BaseResponseModel> failed);

        void ResetPassword(ResetPasswordRequest resetPasswordRequest, Action success, Action<BaseResponseModel> failed);

        void BankDetail(BankRequest bankRequest, Action success, Action<BaseResponseModel> failed);

        void GetStoreWisheshItemDetail(int ListId, Action success, Action<BaseResponseModel> failed);
        void GetList(string Par, Action success, Action<GetListResponse> failed);

        void AddToWishList(AddItemRequest addItemRequest, Action success, Action<BaseResponseModel> failed);
        void ContactUs(ContactUsRequest contactUsRequest, Action success, Action<BaseResponseModel> failed);
        void SendGift(SendGiftRequest contactUsRequest, Action success, Action<BaseResponseModel> failed);
        #endregion

    }
}
