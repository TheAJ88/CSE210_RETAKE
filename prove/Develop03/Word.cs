class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string Display()
    {
        if (_isHidden==true)
        {
            return "_____"; 
        }
        else
        {
            return _word; 
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}

