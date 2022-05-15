# Proiect-
Echipa 4

Tema 1: Aplicație web de gestiune a situației școlare a studenților unei facultăți
Cerințe (User stories):
Studenții au permisiunea de a-și vizualiza situația școlară personală, dar nu pot realiza niciun fel de modificare asupra ei și nu pot vizualiza situația școlară a altor studenți
Profesorii pot adăuga/vizualiza/modifica/șterge note ale studenților înscriși la materiile coordonate de ei
Pentru fiecare notă la fiecare materie a unui student se va menționa data și ora examinării, și se va verifica dacă data este în intervalul de timp alocat sesiunii de examene/restanțe din acel an universitar
Profesorii pot vizualiza diferite rapoarte generate pentru materiile coordonate de ei (numărul de studenți care au promovat un examen, numărul de studenți care nu au promovat un examen, procentul de promovabilitate pentru o anumită materie, etc.)
Utilizatorii cu rol de administrator pot adăuga/vizualiza/modifica/șterge utilizatori de tip profesor/student
Utilizatorul cu rol de administrator sistem poate realiza toate acțiunile de mai sus
Notă: Toți utilizatorii se vor autentifica în sistem cu un nume de utilizator/email și parolă (parola se va stoca hashed în baza de date)

Limbaj - .NET  & Angular
Structura
Pagina 1- login
Pagina 2 – pentru student:   - afisare lista materii la care este inscris (drept doar de citire)
Pagina 3 - Pentru profesori: meniu (modificare nota, adaugare nota, stergere nota) Profesorii pot adăuga/vizualiza/modifica/șterge note ale studenților înscriși la materiile coordonate de ei, generare statistici/rapoarte. – se deschide pe o pagina noua(pagina 6) sau se genereaza ca pdf. Profesorii pot vizualiza diferite rapoarte generate pentru materiile coordonate de ei (numărul de studenți care au promovat un examen, numărul de studenți care nu au promovat un examen, procentul de promovabilitate pentru o anumită materie, etc.)
-	
Pagina 4 – administrator pagina pot adăuga/vizualiza/modifica/șterge utilizatori de tip profesor/student

Pagina 5 - administrator sistem poate realiza toate acțiunile de mai sus.




Baza de date  -  Postgres  SQL

Tabel Utilizatori (ID - PK, Nume, Prenume, email, parola, rol)
Tabel Studenti(ID – PK, email –FK , anStudiu, specializare) 
Tabel Profesori(ID – PK, email -FK, grad didactic)
Tabel Materii (ID – PK, IdProf – FK, Nume materie)
Tabel Note(ID – Pk, ID(Materii) – FK, ID(Profesor), ID(Student)-FK, nota, data si ora examinarii, ID- sesiune-FK)
Tabel Sesiune(ID –PK, Tip sesiune(sesiune normal/restanta),, Anul universitar, Semestru, Data inceput, Data sfarsit)


Saptamana  2 

Am creat clasele entitate.



