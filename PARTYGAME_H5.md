# PARTYGAME projekt tervezet
*Olyan alkalmazást szeretnénk megvalósítani, ami egy házibuli megszervezésében nyújt segítséget.*

#### **Gyakorlatvezető:** Árvai László
#### **Csoport tagjai:**

|NÉV|NEPTUN KÓD|EMAIL|
| :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|onodibenc@gmail.com|
|Gáspár Fanni|VFX06G|fanni.gaspar@gmail.com|
|Baffi Réka|F4IIYA|baffir2@gmail.com|
|Csőre Margaréta|G50NCO|csmargareta2001@gmail.com|
|Karajz Bence|RKFHE0|karajzbence2000@gmail.com|

#### H5 tartalma
1. Bevezetés
2. Általános szoftvertesztelési szempontok

#### H5 elkészítésének naplózása
|NÉV|NEPTUN KÓD|FELADATOK|SZÁZALÉKOS ARÁNY|
| :-: | :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|Bevezetés; |20%|
|Gáspár Fanni|VFX06G||20%|
|Baffi Réka|F4IIYA||20%|
|Csőre Margaréta|G50NCO||20%|
|Karajz Bence|RKFHE0||20%|

### **1. Bevezetés**
Annak érdekében, hogy alkalmazásunk hibátlanul fusson, és megfeleljen a felhasználók igényeinek, tesztelési folyamatokat kell végrehajtani. Az imént említett folyamat biztosítja, hogy a szoftver az elvárásoknak megfelelően működjön a kiadáskor. A tesztelés során olyan hibák derülhetnek ki, amelyek időben kijavíthatók és így hosszú távon nem okoznak komoly anyagi kárt. A modulokat egyenként és a modulok közötti kommunikációt, valamint a teljes programot kell tesztelni.

### **2. Általános szoftvertesztelési szempontok**
##### Funkcionális követelmények tesztelése
A szoftver megírása és tesztelése előtt meg kellett terveznünk, hogy milyen funkcióknak és szoftver követelményeknek kell megfelelnünk, illetve mely platformokra adjuk ki a programot. Csak ezután a pontok kivitelezése után tudjuk a szoftverünket tesztelni. Garantálni kell, hogy a program elinduljon, és a különböző funkciók működjenek.Biztosítani kell a felhasználókat, hogy a szoftver telepítése után azonnal érthető legyen számukra a program összes funkciója, dés egyből tudják használni azt. Emellett biztosítani kell nekik egy felületet, ahol a fellépő hibákat tudják számunkra jelezni, hogy azt később egy patch formájában javíthassuk.

##### Nem-funkcionális követelmények tesztelése
Miután meghatároztuk a rendszerkövetelményeket a szoftverhez, a megfelelő rendszerrel rendelkező felhasználók elvárják tőlünk, hogy a letöltött vagy webes szoftvert a lehető legjobb minőségben szállítsuk le számukra. Vagyis törekednünk kell arra, hogy a szoftver stabil maradjon, ne forduljanak elő sebesség ingadozások, logikai problémák, hisz ezek a problémák rengeteget tudnak elvenni a felhasználói élményről. Fontos a program biztonsága, vagyis, hogy a szoftver ne legyen feltörhető a hackerek számára, különben ez rengeteg funkcionális veszteséget tud okozni, illetve, ha a forráskódhoz is hozzá tudnak férni a szoftver totális tönkretételét tudják okozni.

##### Karbantartás
Gyorsan fejlődő világunkban szinte napi rendszerességgel váltakoznak a különböző hardware-ek, platformok és operációs rendszerek, amelyeknek a kész szoftvernek mindegyikén működnie kell, hogy minél szélesebb körben lehessen élvezni az appot. Ezért csapatunk rendszeresen fogja kiadni a frissítéseket a programhoz, hogy az minél stabilabban működjön. Mivel szeretnénk később tovább bővülni különböző funkciókkal megeshet, hogy ezek a változtatások „bugokat” idézhetnek elő, legrosszabb esetben leállíthatja a programot. Ekkor ha kell, visszatérünk az előző, működő verzióra, míg a hibát teljesen ki nem javítottuk. Minden frissítés után honlapunkon elérhetővé válik, hogy milyen hibákat javítottunk ki illetve a programon belül jelezve lesz, hogy a következő frissítés hozzávetőlegesen mikorra várható.
