# CheckersGame
Am realizat un joc de dame in C#, folosind o interfata grafica utilizator dezvoltata in
WPF. Aplicatia este dezvoltata pe design paternul MVVM. Jucatorul cu piesele rosii este primul care muta, dupa care vor efectua pe rand, cate
o mutare, fiecare dintre jucatori. Aplicatia marcheaza vizual jucatorul care este la mutare.
Exista mai multe tipuri de mutări:
• Mutarea simpla – piesa se deplaseaza o casuta, pe diagonala, in fata. Daca piesa
a reusit sa ajunga la capatul opus al tablei de joc, atunci se va transforma in
„rege” şi mutarea sa va fi tot cu o casuta, pe diagonala, dar se va putea deplasa
atat in fata cat si in spate. 
• Saritura peste adversar – atunci cand o piesa are o piesa adversa pe una dintre
pozitiile sale de mutare, atunci acea piesa va sari peste cea adversa, facand-o sa
dispara de pe tabla de joc. Un jucător poate sari doar peste piesele adversarului
pentru a le captura, nu si peste piese de ale sale.
• Sarituri multiple – daca un jucator a sarit peste o piesa adversa si in imediata
vecinatate a sa se gaseste inca o piesa adversa care poate fi capturata, va face
inca o saritura, si tot asa pana cand nu va mai putea captura piese adverse.
Jucatorii vor putea efectua aceste sarituri doar daca se opteaza inca de la
inceputul jocului pentru efectuarea de sarituri multiple.
Finalul jocului – jocul se incheie in momentul in care unul dintre jucatori nu mai are
piese pe tabla de joc. Jucatorul advers va fi in acest caz castigatorul.
Se permite salvarea starii jocului. La pornirea aplicatiei utilizatorul poate incepe
un nou joc sau sa incarce unul salvat anterior.
