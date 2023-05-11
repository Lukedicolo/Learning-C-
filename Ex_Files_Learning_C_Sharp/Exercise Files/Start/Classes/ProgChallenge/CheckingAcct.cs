using System;

namespace ProgChallenge
{
    class CheckingAcct : Account{
        private const decimal OVERDRAW_CHARGE = 35.0m;
        public CheckingAcct(string firstName, string lastName, decimal balance)
            : base(firstName, lastName, balance){ 
        }

        public override void Withdraw(decimal ammount)
        {
            if (_balance < ammount){
                _balance -= OVERDRAW_CHARGE;
            }
            base.Withdraw(ammount);
        }
    }
}