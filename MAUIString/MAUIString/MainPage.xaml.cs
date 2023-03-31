namespace MauiString;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	int Lunghezza(string l)//Funzione per il length(al posto di utilizzare il length si utilizza questa funzione)
	{
		char[] caratteri = l.ToCharArray();
		int retVal = 0;
		foreach (char carattere in caratteri)
			retVal++;
		return retVal;
	}
	char ToUpper(char c)//Creazione del ToUpper da inserire nella funzione maiuscolo
	{
		if (c >= 'a' && c <= 'z')
		{
			int a = (int)c & 0xDF;//usando la tabella ASCII(convertendo in esadecimale) siamo arrivati a questo valore
			return (char)a;
		}
		return c;
	}
	string Maiuscolo(string s)
	{
		//Convertire una stringa  in array
		char[] caratteri = s.ToCharArray();
		//Ciclo per far scorrere vettore
		for (int x = 0; x < Lunghezza(s); x++)
			caratteri[x] = ToUpper(caratteri[x]);
		//Convertiamo l'array in  stringa(l'opposto di quello fatto in precedenza)
		return new String(caratteri);
	}


	char ToLower(char c)
	{
		if (c >= 'A' && c <= 'Z')
		{
			int a = (int)c | 0x20;
			return (char)a;
		}
		return c;
	}

	string Minuscolo(string s)
	{
        
        char[] caratteri = s.ToCharArray();
		for (int x = 0; x < Lunghezza(s); x++)
			caratteri[x] = ToLower(caratteri[x]);
        return new String(caratteri);
    
	}

	bool isLetter(char c)
	{
		if ((c >= 'a' && c <= 'z'))
		{
			return true;	
		}
        if ((c >= 'A' && c <= 'Z'))
        {
            return true;
        }
        return false;
	}
	int NumeroLettere(string s)
	{
		int Length = Lunghezza(s);
        char[] caratteri = s.ToCharArray();
		int i = 0;
		for (int idx = 0; idx < Length; idx++)
		{
			if (isLetter(caratteri[idx]))
			{
				i ++;

			}
			
		}
		return i;



    }
    bool isNumber(char c)
    {
        if ((c >= '0' && c <= '9'))
        {
            return true;
        }
        return false;
    }

	bool Alfanumerico(string s)
	{
		int l = Lunghezza(s);
        char[] caratteri = s.ToCharArray();
		for(int idx = 0; idx < l; idx++)
		{
			if (isLetter(caratteri[idx]) || isNumber(caratteri[idx]))
			{

			}
			else
			{
				return false;
			}

		}
		return true;

    }

	bool Alfabetico(string s)
	{
        int l = Lunghezza(s);
        char[] caratteri = s.ToCharArray();
        for (int idx = 0; idx < l; idx++)
        {
            if (isLetter(caratteri[idx]))
            {

            }
            else
            {
                return false;
            }

        }
        return true;

    }
	
	string Reverse(string s)
	{
        int l = (Lunghezza(s)-1);
        char[] caratteri = s.ToCharArray();
		char[] tmp = new char[1];
		for(int idx = 0; idx < l; idx++)
		{
			tmp[0] = caratteri[idx];
			caratteri[idx] = caratteri[l];
			caratteri[l] = tmp[0];
			l--;


		}
		return new string(caratteri);


    }

	


    private void OnCounterClicked(object sender, EventArgs e)
	{
		


		letteramaiuscola.Text = Maiuscolo(edTesto.Text);
        letteraminuscola.Text = Minuscolo(edTesto.Text);
		nlettere.Text = NumeroLettere(edTesto.Text).ToString();
        letteraalfanumerica.Text =Alfanumerico(edTesto.Text).ToString();
		letteraalfabetica.Text = Alfabetico(edTesto.Text).ToString();
		letterareverse.Text = Reverse(edTesto.Text);


        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

