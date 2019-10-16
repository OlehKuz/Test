using System;
using BOWTest.Models.REST;

namespace TradingApiLogin.Models.REST
{

    public class BaseConfigurationLoginServlet : LoginServletModel
    {
        public BaseConfigurationLoginServlet()
        {
            LoginId = "SER_CT2-T9072";
            USPassword = "ser.123456";
            Version = "1.3044";
            SecuritiesMaxSequenceId = 1;
            NSEContractsMaxSequenceId = 82;
            NcdexContractsMaxSequenceId = 60;
            MCXContractsMaxSequenceId = 139;
            BSEContractsMaxSequenceId = 1;
            BSECurrencyContractsMaxSequenceId = 1;
            NSECurrencyContractsMaxSequenceId = 2125;
            Enable2FA = "Y";
            VenderCode = "8_SER";
            ThickClient = "Y";

        }


    }
}
