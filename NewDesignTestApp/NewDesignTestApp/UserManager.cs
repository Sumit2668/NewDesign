using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using GFDT.Providers.ApiProvider;
using GFDT.Managers.SettingsManager;
using Xamarin.Forms.Internals;
using GFDT.Managers.UserManager;
using GFDT.Models.Response;
using GFTD.Models.Request;
using GFTD.Models.Response;
using GFDT.Models.Request;

namespace GFDT.Managers.UserManager
{
    public class UserManager : IUserManager
    {
        #region Connectivity
        public bool IsConnected()
        {
            // var networkConnection = Xamarin.Forms.DependencyService.Get<Services.IMediaService>().CheckNewworkConnectivity().Result; //CrossConnectivity.Current.IsConnected;
            return true;// networkConnection;
        }
        #endregion

        #region Property
        private readonly IApiProvider _apiProvider;
        private readonly ISettingsManager _settingsManager;
        #endregion

        #region


        private LoginResponse loginResponse { get; set; }

        private CompleteProfileResponse completeProfileResponse { get; set; }
        private OTPVerificationResponse otpverificationResponse { get; set; }
        private SignupResponse signupResponse { get; set; }
        private ResetPasswordResponse resetPasswordResponse { get; set; }
        private GetListItemResponce getlistItemResponce { get; set; }
        private GetListResponse getListResponse { get; set; }
        private BaseResponseModel addItemResponse { get; set; }
        private BaseResponseModel contactUsResponse { get; set; }
        private BaseResponseModel sendGiftResponse { get; set; }

        public GetListItemResponce GetListItemResponce => getlistItemResponce;
        public GetListResponse GetListResponse => getListResponse;
        private BankResponse bankResponse { get; set; }
        public BankResponse BankResponse => bankResponse;
        public ResetPasswordResponse ResetPasswordResponse => resetPasswordResponse;
        public OTPVerificationResponse OTPVerificationResponse => otpverificationResponse;
        public LoginResponse LoginResponse => loginResponse;
        public CompleteProfileResponse CompleteProfileResponse => completeProfileResponse;
        public SignupResponse SignupResponse => signupResponse;
        public BaseResponseModel AddItemResponse => addItemResponse;
        public BaseResponseModel ContactUsResponse => contactUsResponse;
        public BaseResponseModel SendGiftResponse => sendGiftResponse;

        #endregion

        #region Header
        public Dictionary<string, string> GetHeaders()
        {
            //Authorization: Bearer ZEmEQtlZ8uSmAjDSTkSPiCkRPesno0GB5
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("Authorization", $"{"Bearer "}ZEmEQtlZ8uSmAjDSTkSPiCkRPesno0GB5");
            // header.Add("auth-secret", "Ak12mr27Xwg@d89ul");
            return header;
        }
        public Dictionary<string, string> SignupHeaders()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("Authorization", $"{"Bearer "}ZEmEQtlZ8uSmAjDSTkSPiCkRPesno0GB5cvT0GVERoJxup7z45edjV5npfK");

            return header;
        }
        public Dictionary<string, string> CompleteHeaders()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("X-Access-Token", "MTMyMTU0NTYxMA==");
            return header;
        }

        public Dictionary<string, string> BankHeaders()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("X-Access-Token", "MTMyMTU0NTYxMA==");
            return header;
        }

        public Dictionary<string, string> GetListHeaders()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("X-Access-Token", "MTMyMTU0NTYx");
            return header;
        }
        public Dictionary<string, string> Headers()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("X-Access-Token", "MTMyMTU0NTYx");
            return header;
        }

        #endregion

        public async void Login(LoginRequest loginRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}login", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<LoginResponse, LoginRequest>(url, loginRequest);
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            loginResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void Signup(SignupRequest signupRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}signup", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<SignupResponse, SignupRequest>(url, signupRequest, SignupHeaders());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            signupResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                }
                catch (Exception exe)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }

        }

        public async void CompleteProfile(CompleteProfileRequest completeProfileRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}completeProfile", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<CompleteProfileResponse, CompleteProfileRequest>(url, completeProfileRequest, CompleteHeaders());
                    //var result = await _apiProvider.Post<SignupResponse, SignupRequest>(url, signupRequest, SignupHeaders());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            completeProfileResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }

        }

        public async void OTPVerification(OTPVerificationRequest otpverificationRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}otpVerification", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<OTPVerificationResponse, OTPVerificationRequest>(url, otpverificationRequest);
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            otpverificationResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void ResetPassword(ResetPasswordRequest resetPasswordRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}resetpassword", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<ResetPasswordResponse, ResetPasswordRequest>(url, resetPasswordRequest);
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            resetPasswordResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void BankDetail(BankRequest bankRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}bankDetail", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<BankResponse, BankRequest>(url, bankRequest, BankHeaders());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            bankResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        //Sumit

        public async void GetStoreWisheshItemDetail(int ListId, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}getList/" + ListId.ToString(), _settingsManager.ApiHost);
                    var result = await _apiProvider.Get<GetListItemResponce>(url, GetListHeaders());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            getlistItemResponce = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void ReceivedGift(int userid, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}getList/" + userid.ToString(), _settingsManager.ApiHost);
                    var result = await _apiProvider.Get<GetListItemResponce>(url, GetListHeaders());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            getlistItemResponce = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }
        //Sumit
        public async void AddToWishList(AddItemRequest addItemRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}addItem", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<BaseResponseModel, AddItemRequest>(url, addItemRequest, Headers());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            addItemResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void ContactUs(ContactUsRequest contactUsRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}contactus", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<BaseResponseModel, ContactUsRequest>(url, contactUsRequest);
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            contactUsResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void SendGift(SendGiftRequest sendGiftRequest, Action success, Action<BaseResponseModel> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}sendgift", _settingsManager.ApiHost);
                    var result = await _apiProvider.Post<BaseResponseModel, SendGiftRequest>(url, sendGiftRequest, Headers());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            sendGiftResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                BaseResponseModel error = new BaseResponseModel { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }

        public async void GetList(string Par ,Action success, Action<GetListResponse> failed)
        {
            bool IsNetwork = IsConnected();
            if (IsNetwork)
            {
                try
                {
                    var url = string.Format("{0}getList/"+Par.ToString(), _settingsManager.ApiHost);
                    var result = await _apiProvider.Get<GetListResponse>(url, GetListHeaders());
                    if (result.Result.status == true)
                    {
                        if (success != null)
                        {
                            getListResponse = result.Result;
                            success.Invoke();
                        }
                        else
                        {
                            failed.Invoke(result.Result);
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                GetListResponse error = new GetListResponse { message = "Please check your internet connection!" };
                failed.Invoke(error);
            }
        }


        #region Constructor

        public UserManager(IApiProvider apiProvider, ISettingsManager settingsManager)
        {
            _apiProvider = apiProvider;
            _settingsManager = settingsManager;
        }
        #endregion
    }
}
