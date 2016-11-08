namespace Division
{
    //***GCD means Greatest Common Divisior
    //***GCD는 최대 공약수의 약자
    class Divisor
    {
        private int GCD;
        private bool divided;     
        private int divisor;

        private int Compare(int a, int b)
        {
            //retrun smaller one
            //작은 수 반환
            if (a < b) { return a; }
            else { return b; }
        }

        private bool Division(int target, int divisor)
        {
            //return status of target can divied by divisor
            //divisor로 target을 나눌 수 있는지 반환
            if (target % divisor == 0) { return true; }
            else { return false; }
        }

        public int GetGCD(int a, int b)
        {
            GCD = 1;
            divided = false;
            divisor = 1;
            //call Compare(int a, int b) 
            //작은 수 비교함수 호출
            int min = Compare(a, b);
            //ex) min == 20, divisor's value is in 1~20
            //예시) 작은값이 20이면 공약수의 범위는 20을 벗어나지 않음
            while (divisor <= min)
            {
                //if divisor can divied a and b, substituting in GCD
                //만약 divisor가 a와b 둘다 나누어지면 최대공약수에 대입
                if (Division(a, divisor) && Division(b, divisor))
                {
                    GCD = divisor;
                    divided = true;
                }
                divisor++;
            }
            //if it does not divided at all, return 0
            //만약 한번도 나누어떨어지지 않으면 0 반환 
            if (divided) { return GCD; }
            else { return 0; }
        }
    }
}
