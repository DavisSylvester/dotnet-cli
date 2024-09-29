using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_cli.Interfaces
{
    public interface IAuth0Service
    {
        public Task<bool> CreatePermission();
    }
}
