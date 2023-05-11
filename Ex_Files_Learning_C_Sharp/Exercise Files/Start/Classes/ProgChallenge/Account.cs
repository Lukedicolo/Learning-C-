using System;

namespace ProgChallenge
{
    class Account{
        protected string _firstName;
        protected string _lastName;
        protected decimal _balance;
        public Account(string firstName, string lastName, decimal balance){
            _firstName = firstName;
            _lastName = lastName;
            _balance = balance;
        }

        public string FirstName{
            get {return _firstName;}

            set {
                if (value == ""){
                    throw new ArgumentException("Name cannot be blank.");
                }
                _firstName = value;
            }
        }
        
        public string LastName{
            get {return _lastName;}

            set {
                if (value == ""){
                    throw new ArgumentException("Name cannot be blank.");
                }
                _lastName = value;
            }
        }

        public string AccountOwner{
            get {return $"{_firstName} {_lastName}";}
        }

        public string Balance{
            get {return $"{_balance}";}
        }

        public virtual void Deposit(decimal ammount){
            _balance += ammount;
        }

        public virtual void Withdraw(decimal ammount){
            _balance -= ammount;
        }
    }
}