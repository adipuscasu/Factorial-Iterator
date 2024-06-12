
using System.Collections;
using System.Numerics;

public class FactorialEnumerator : IEnumerator<BigInteger>
{
    private BigInteger _n;
    private BigInteger _current;
    private BigInteger _currentFactorial;

    public FactorialEnumerator(BigInteger n)
    {
        _n = n;
        _current = 0;
        _currentFactorial = 1;
    }

    public bool MoveNext()
    {
        if (_current <= _n)
        {
            if (_current == 0 || _current == 1)
            {
                _currentFactorial = 1;
            }
            else
            {
                _currentFactorial *= _current;
            }

            _current++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _current = 0;
        _currentFactorial = 1;
    }

    public BigInteger Current => _currentFactorial;

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // No resources to dispose
    }
}

