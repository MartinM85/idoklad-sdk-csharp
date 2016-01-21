﻿using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    public class ExchangeRateClient : BaseClient
    {
        internal const string ResourceUrl = "/ExchangeRates";

        public ExchangeRateClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/ExchangeRates
        /// Method returns list of exchange rates.
        /// </summary>
        public RowsResultWrapper<ExchangeRate> ExchangeRates()
        {
            return base.Get<RowsResultWrapper<ExchangeRate>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/ExchangeRates/{id}
        /// Method returns exchange rate by Id.
        /// </summary>
        public ExchangeRate ExchangeRate(int exchangeRateId)
        {
            return base.Get<ExchangeRate>(ResourceUrl + "/" + exchangeRateId);
        }
    }
}