using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Repository.Impl
{
    internal class InitalLoadSeed : IInitalLoadSeed
    {
        private readonly IApplicationIdRepository _applicationIdRepository;

        public InitalLoadSeed(IApplicationIdRepository applicationIdRepository)
        {
            _applicationIdRepository = applicationIdRepository;
        }

        public Task InitialLoadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
