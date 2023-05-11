using System;

namespace ProgChallenge
{
    class SavingsAcct: Account{
        private decimal _interest;
        public SavingsAcct(string firstName, string lastName, decimal interest=0.025m, decimal balance=0.0m)
            : base(firstName, lastName, balance){
            _interest = interest;
        }
        private int withdrawalCount = 0;
        private const decimal WITHDRAWAL_CHARGE = 2.0m;
        private const int WITHDRAWAL_COUNT = 3;

        public override void Withdraw(decimal ammount){
            decimal newBalance = _balance - ammount;
            
            // Can't allow overdrawal in savings accounts..
            if (_balance < ammount){
                Console.WriteLine("Operation DENIED - Savings accounts cannot be overdrawn.");
                Console.WriteLine($"Your current balance is {_balance}.");
            }
            else {
                base.Withdraw(ammount);
                // Check if they've gone over the free withdrawal limit
                if (withdrawalCount > WITHDRAWAL_CHARGE){
                    Console.WriteLine("More than 3 withdrawals made. You will incur a £2 charge.");
                    _balance -= WITHDRAWAL_CHARGE;
                }

                // AFTER withdrawal made, increase count. NOT before like video had...
                withdrawalCount++;
            }
        }

        public void ApplyInterest(){
            if (1500.0m <= _balance && _balance < 5000.0m) {
                _interest = 0.035m;
            }
            if (_balance >= 5000.0m) {
                _interest = 0.045m;
            }
            Console.WriteLine($"Your current balance means you will receive an interest rate of {_interest*100:F1}%");
            _balance += Math.Round(_balance * _interest, 2);
        }

        // Add function to reset the withdrawal count. Maybe X months...
        public void ResetWithdrawalCount(){
            withdrawalCount = 0;
        }
    }
}