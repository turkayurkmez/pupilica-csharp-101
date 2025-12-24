using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractVEInterface
{
    public class Oyuncu
    {
        public void Giy(IKiyafet kiyafet) //Tightly Coupled!!!
                                                   //Loosely Coupled!!!
        {

        }
    }

    public interface IKiyafet
    {

    }
    public class UstGiyim :IKiyafet
    {

    }

    public class Kazak : UstGiyim
    {

    }

    public class Tisort : UstGiyim
    {

    }

    public class KirmiziKazak : Kazak
    {

    }
}
