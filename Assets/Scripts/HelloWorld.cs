using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int _foo;
    public int _maxNumber;
    public bool _maxBool;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        CheckNumber();
    }
    public void CheckNumber()
    {
        if (_foo < _maxNumber && _maxBool == false)
        {
            _foo = _foo + 1;
            print("foo: " + _foo);
        }
        else
        {
            _maxBool = true;
            print("Max hit. foo: " + _foo);
        }
        if (_maxBool == true)
        {
            _foo--;
        }

        //while (_foo < _maxNumber && !_maxBool)
        //{
        //    _foo++;
        //    print("foo: " + _foo);
        //}
        //print("_max hit");



    }
}
