using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace crWordForms
{
    public class easyWord {
        private Word.Application nWord; 


        easyWord() {
            nWord=new Word.Application();

        }
    }
}
