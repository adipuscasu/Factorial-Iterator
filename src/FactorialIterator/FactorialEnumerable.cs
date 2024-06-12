
using System.Collections;
using System.Numerics;

public class FactorialEnumerable(BigInteger n) : IEnumerable<BigInteger>
{
    private BigInteger _n = n;

    public IEnumerator<BigInteger> GetEnumerator()
    {
        return new FactorialEnumerator(_n);
    }
}
