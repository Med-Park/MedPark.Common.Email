using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedPark.Common.Email
{
    public interface IEmailTemplateingService
    {
        Task<string> LoadTemplate(string name);
    }
}
