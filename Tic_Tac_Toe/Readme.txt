# Tetris - Python Game

## Ülevaade

**Tetris** on klassikaline puzzle-mäng, kus mängija peab keerukalt paigutama erinevaid geomeetrilisi kujundeid (tükke) ekraanile. Kui tükid täidavad terve rea, siis see rida kaob ja mängija saab punkte. Mäng muutub aja jooksul järjest kiiremaks, suurendades väljakutse taset. Mäng lõpeb, kui tükid ulatuvad ekraani ülemise servani.

## Funktsioonid

- **Tükkide genereerimine**: Erinevad geomeetrilised kujundid (nt: I, O, T, L, Z, S).
- **Keeramine ja liikumine**: Tükid saavad liikuda vasakule, paremale ja alla. Samuti saab neid keerata.
- **Täidetud ridade eemaldamine**: Kui täidetakse kogu rida, siis see kaob ja mängija saab punkte.
- **Kiirus**: Mängu kiirus suureneb järk-järgult, kui mäng kestab kauem.
- **Punktide arvestus**: Mängija saab punkte iga täidetud rea eest.
- **Lõpp**: Mäng lõpeb, kui tükid ulatuvad ekraani ülemisse ossa.

## Tehnilised detailid

- **Tehnoloogia**: Python 3, Pygame
- **Keel**: Python
- **Raamatukogud**: 
  - [Pygame](https://www.pygame.org) - kasutan Pygame'i, et luua visuaali ja hallata mängu dünaamikat.
  - `random` - tükkide genereerimiseks juhuslikkuse loomine.
  - `time` - mängu kiirus ja viivitused.
  
## Kuidas alustada

### Eeltingimused

Veendu, et sul on Python 3.x paigaldatud. Samuti tuleb paigaldada Pygame:

```bash
pip install pygame
