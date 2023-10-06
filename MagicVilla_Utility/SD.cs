﻿namespace MagicVilla_Utility
{
    public static class SD
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public static string AccessToken = "JWTToken";
        public static string RefreshToken = "RefreshToken";
        public static string CurrentAPIVersion = "v2";
        public const string Admin = "admin";
        public const string Customer = "customer";
        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}