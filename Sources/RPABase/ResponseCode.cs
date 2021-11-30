using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase
{
    public static class ResponseCode
    {
        public const int SUCCESS = 0;

        public static string GetMessage(int code)
        {
            switch (code)
            {
                case ResponseCode.SUCCESS: return "成功";

                default:
                    return string.Format("未知错误码:{0}", code);
            }
        }
    }
}
