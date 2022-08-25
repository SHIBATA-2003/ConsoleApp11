namespace CS17
{
    class Customer
    {
       static void Main()
        {

        }
        
        public string FirstName;
        public string LastName;
      
        ///
        /// コンストラクタ（フルネーム指定）
        /// 
        ///名
        ///姓
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        ///
        /// コンストラクタ（苗字指定）
        /// 
        ///姓
        public Customer(string lastName) : this("--", lastName)
        {
            //コンストラクタイニシャライザによりここに重複コードを書く必要がなくなる
            ////FirstName = "--";
            ////LastName = lastName;
        }

        ///
        /// フルネームの取得
        /// 
        /// 
        public string GetFullName()
        {
            return LastName + FirstName;
        }
       
    }
}