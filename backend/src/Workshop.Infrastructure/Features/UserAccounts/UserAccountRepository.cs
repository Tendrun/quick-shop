using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Application.Features.UserAccounts;
using Workshop.Domain.Features.Product;
using Workshop.Domain.Features.UserAccounts;

namespace Workshop.Infrastructure.Features.UserAccounts {
    public class UserAccountRepository : IUserAccountRepository {
        IUserAccountRepository userAccountRepository;
        public UserAccountRepository(IUserAccountRepository userAccountRepository) {
            this.userAccountRepository = userAccountRepository;
        }

        public Task<UserAccount?> GetByIdAsync(int id) {

            throw new NotImplementedException();

        }

        public Task<UserAccount> CreateAsync (UserAccount userAccount) {
            throw new NotImplementedException();
        }
    }
}
