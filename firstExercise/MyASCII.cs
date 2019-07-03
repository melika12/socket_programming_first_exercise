using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstExercise
{
    class MyASCII
    {
        public byte[] fromStringToBytes(string a)
        {
            char[] chars = new char[a.Length];
            byte[] arrayOfBytes = new byte[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                chars[i] = a[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case ' ':
                        arrayOfBytes[i] = 32;
                        break;
                    case '!':
                        arrayOfBytes[i] = 33;
                        break;
                    case '"':
                        arrayOfBytes[i] = 34;
                        break;
                    case '#':
                        arrayOfBytes[i] = 35;
                        break;
                    case '$':
                        arrayOfBytes[i] = 36;
                        break;
                    case '%':
                        arrayOfBytes[i] = 37;
                        break;
                    case '&':
                        arrayOfBytes[i] = 38;
                        break;
                    case '\'':
                        arrayOfBytes[i] = 39;
                        break;
                    case '(':
                        arrayOfBytes[i] = 40;
                        break;
                    case ')':
                        arrayOfBytes[i] = 41;
                        break;
                    case '*':
                        arrayOfBytes[i] = 42;
                        break;
                    case '+':
                        arrayOfBytes[i] = 43;
                        break;
                    case ',':
                        arrayOfBytes[i] = 44;
                        break;
                    case '-':
                        arrayOfBytes[i] = 45;
                        break;
                    case '.':
                        arrayOfBytes[i] = 46;
                        break;
                    case '/':
                        arrayOfBytes[i] = 47;
                        break;
                    case '0':
                        arrayOfBytes[i] = 48;
                        break;
                    case '1':
                        arrayOfBytes[i] = 49;
                        break;
                    case '2':
                        arrayOfBytes[i] = 50;
                        break;
                    case '3':
                        arrayOfBytes[i] = 51;
                        break;
                    case '4':
                        arrayOfBytes[i] = 52;
                        break;
                    case '5':
                        arrayOfBytes[i] = 53;
                        break;
                    case '6':
                        arrayOfBytes[i] = 54;
                        break;
                    case '7':
                        arrayOfBytes[i] = 55;
                        break;
                    case '8':
                        arrayOfBytes[i] = 56;
                        break;
                    case '9':
                        arrayOfBytes[i] = 57;
                        break;
                    case ':':
                        arrayOfBytes[i] = 58;
                        break;
                    case ';':
                        arrayOfBytes[i] = 59;
                        break;
                    case '<':
                        arrayOfBytes[i] = 60;
                        break;
                    case '=':
                        arrayOfBytes[i] = 61;
                        break;
                    case '>':
                        arrayOfBytes[i] = 62;
                        break;
                    case '?':
                        arrayOfBytes[i] = 63;
                        break;
                    case '@':
                        arrayOfBytes[i] = 64;
                        break;
                    case 'A':
                        arrayOfBytes[i] = 65;
                        break;
                    case 'B':
                        arrayOfBytes[i] = 66;
                        break;
                    case 'C':
                        arrayOfBytes[i] = 67;
                        break;
                    case 'D':
                        arrayOfBytes[i] = 68;
                        break;
                    case 'E':
                        arrayOfBytes[i] = 69;
                        break;
                    case 'F':
                        arrayOfBytes[i] = 70;
                        break;
                    case 'G':
                        arrayOfBytes[i] = 71;
                        break;
                    case 'H':
                        arrayOfBytes[i] = 72;
                        break;
                    case 'I':
                        arrayOfBytes[i] = 73;
                        break;
                    case 'J':
                        arrayOfBytes[i] = 74;
                        break;
                    case 'K':
                        arrayOfBytes[i] = 75;
                        break;
                    case 'L':
                        arrayOfBytes[i] = 76;
                        break;
                    case 'M':
                        arrayOfBytes[i] = 77;
                        break;
                    case 'N':
                        arrayOfBytes[i] = 78;
                        break;
                    case 'O':
                        arrayOfBytes[i] = 79;
                        break;
                    case 'P':
                        arrayOfBytes[i] = 80;
                        break;
                    case 'Q':
                        arrayOfBytes[i] = 81;
                        break;
                    case 'R':
                        arrayOfBytes[i] = 82;
                        break;
                    case 'S':
                        arrayOfBytes[i] = 83;
                        break;
                    case 'T':
                        arrayOfBytes[i] = 84;
                        break;
                    case 'U':
                        arrayOfBytes[i] = 85;
                        break;
                    case 'V':
                        arrayOfBytes[i] = 86;
                        break;
                    case 'W':
                        arrayOfBytes[i] = 87;
                        break;
                    case 'X':
                        arrayOfBytes[i] = 88;
                        break;
                    case 'Y':
                        arrayOfBytes[i] = 89;
                        break;
                    case 'Z':
                        arrayOfBytes[i] = 90;
                        break;
                    case '[':
                        arrayOfBytes[i] = 91;
                        break;
                    case '\\':
                        arrayOfBytes[i] = 92;
                        break;
                    case ']':
                        arrayOfBytes[i] = 93;
                        break;
                    case '^':
                        arrayOfBytes[i] = 94;
                        break;
                    case '_':
                        arrayOfBytes[i] = 95;
                        break;
                    case '`':
                        arrayOfBytes[i] = 96;
                        break;
                    case 'a':
                        arrayOfBytes[i] = 97;
                        break;
                    case 'b':
                        arrayOfBytes[i] = 98;
                        break;
                    case 'c':
                        arrayOfBytes[i] = 99;
                        break;
                    case 'd':
                        arrayOfBytes[i] = 100;
                        break;
                    case 'e':
                        arrayOfBytes[i] = 101;
                        break;
                    case 'f':
                        arrayOfBytes[i] = 102;
                        break;
                    case 'g':
                        arrayOfBytes[i] = 103;
                        break;
                    case 'h':
                        arrayOfBytes[i] = 104;
                        break;
                    case 'i':
                        arrayOfBytes[i] = 105;
                        break;
                    case 'j':
                        arrayOfBytes[i] = 106;
                        break;
                    case 'k':
                        arrayOfBytes[i] = 107;
                        break;
                    case 'l':
                        arrayOfBytes[i] = 108;
                        break;
                    case 'm':
                        arrayOfBytes[i] = 109;
                        break;
                    case 'n':
                        arrayOfBytes[i] = 110;
                        break;
                    case 'o':
                        arrayOfBytes[i] = 111;
                        break;
                    case 'p':
                        arrayOfBytes[i] = 112;
                        break;
                    case 'q':
                        arrayOfBytes[i] = 113;
                        break;
                    case 'r':
                        arrayOfBytes[i] = 114;
                        break;
                    case 's':
                        arrayOfBytes[i] = 115;
                        break;
                    case 't':
                        arrayOfBytes[i] = 116;
                        break;
                    case 'u':
                        arrayOfBytes[i] = 117;
                        break;
                    case 'v':
                        arrayOfBytes[i] = 118;
                        break;
                    case 'w':
                        arrayOfBytes[i] = 119;
                        break;
                    case 'x':
                        arrayOfBytes[i] = 120;
                        break;
                    case 'y':
                        arrayOfBytes[i] = 121;
                        break;
                    case 'z':
                        arrayOfBytes[i] = 122;
                        break;
                    case '{':
                        arrayOfBytes[i] = 123;
                        break;
                    case '|':
                        arrayOfBytes[i] = 124;
                        break;
                    case '}':
                        arrayOfBytes[i] = 125;
                        break;
                    case '~':
                        arrayOfBytes[i] = 126;
                        break;
                    default:
                        break;
                }
            }
            return arrayOfBytes;
        } 
    }
}
