using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class Auth : IAuth
	{
		public async Task<bool> ChallengeAuth(string user, string password)
		{
			return true;
		}
	}
}
