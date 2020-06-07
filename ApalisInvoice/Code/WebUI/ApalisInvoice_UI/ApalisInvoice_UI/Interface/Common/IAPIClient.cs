using ApalisInvoiceViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Interface.Common
{
    public interface IAPIClient
    {
        Task<T> GetAsync<T>(string apiUrl);
        Task<MessageViewModel<T1>> PostAsync<T1, T2>(string apiUrl, T2 content);
    }
}
