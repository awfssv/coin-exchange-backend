/***************************************************************************** 
* Copyright 2016 Aurora Solutions 
* 
*    http://www.aurorasolutions.io 
* 
* Aurora Solutions is an innovative services and product company at 
* the forefront of the software industry, with processes and practices 
* involving Domain Driven Design(DDD), Agile methodologies to build 
* scalable, secure, reliable and high performance products.
* 
* Coin Exchange is a high performance exchange system specialized for
* Crypto currency trading. It has different general purpose uses such as
* independent deposit and withdrawal channels for Bitcoin and Litecoin,
* but can also act as a standalone exchange that can be used with
* different asset classes.
* Coin Exchange uses state of the art technologies such as ASP.NET REST API,
* AngularJS and NUnit. It also uses design patterns for complex event
* processing and handling of thousands of transactions per second, such as
* Domain Driven Designing, Disruptor Pattern and CQRS With Event Sourcing.
* 
* Licensed under the Apache License, Version 2.0 (the "License"); 
* you may not use this file except in compliance with the License. 
* You may obtain a copy of the License at 
* 
*    http://www.apache.org/licenses/LICENSE-2.0 
* 
* Unless required by applicable law or agreed to in writing, software 
* distributed under the License is distributed on an "AS IS" BASIS, 
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
* See the License for the specific language governing permissions and 
* limitations under the License. 
*****************************************************************************/


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinExchange.Funds.Domain.Model.FeeAggregate
{
    /// <summary>
    /// Interface for Fee Repository
    /// </summary>
    public interface IFeeRepository
    {
        /// <summary>
        /// Gets the Fee by providing the database primary key ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Fee GetFeeById(int id);

        /// <summary>
        /// Gets the Fee by providing the Currency Pair
        /// </summary>
        /// <param name="currencyPair"></param>
        /// <returns></returns>
        List<Fee> GetFeeByCurrencyPair(string currencyPair);

        /// <summary>
        /// Gets the Fee corresponding to the given currency and the amount
        /// </summary>
        /// <param name="currencyPair"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        Fee GetFeeByCurrencyAndAmount(string currencyPair, int amount);

        /// <summary>
        /// Gets the fees for every currency pair
        /// </summary>
        /// <returns></returns>
        List<Fee> GetAllFees();
    }
}
