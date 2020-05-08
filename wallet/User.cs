using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet
{
    class User
    {
        public string Name { get; set; }
        public List<Wallet> Wallets { get; protected set; } = new List<Wallet>();

        public User(string name)
        {
            this.Name = name;
        }

        public override string ToString() {
            return Name;
        }
    }
}
