using System;
using System.Linq;

namespace CaesarCipher{
    public static class RotationalCipher{
        public static string Rotate(string text, int shiftKey){
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++){
                char letter = buffer[i];
                if(Char.IsLetter(buffer[i])){
                    letter = (char)(letter + shiftKey); //Shift only if buffer is Character
                } else {
                    continue;
                } 
                if (Char.IsLower(buffer[i])){
                    if (letter > 'z'){
                        letter = (char)(letter - 26);   //Subtract 26 on overflow.
                    }
                    else if (letter < 'a'){
                        letter = (char)(letter + 26);   //Add 26 on underflow.
                    }
                } else {
                    if (letter > 'Z'){
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'A'){
                        letter = (char)(letter + 26);
                    }
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
