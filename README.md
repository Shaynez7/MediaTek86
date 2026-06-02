# Application MediaTek86
Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL.<br><br>

## Présentation de l'application
### Présentation du contexte
InfoTech Services 86 (ITS 86), est une Entreprise de Services Numériques (ESN) spécialisée dans le développement informatique (applications de bureau, web, mobile), l’hébergement de site web, l’infogérance, la gestion de parc informatique et l’ingénierie système et réseau. Elle répond régulièrement à des appels d’offres en tant que société d’infogérance et prestataire de services informatiques. ITS 86 propose un accompagnement complet de votre projet. De la conception d'une application adaptée à vos besoins à son intégration avec les logiciels dont vous êtes déjà équipés, en passant par le développement. Notre large éventail de partenaires favorise notre capacité d'innovation, permet de proposer des solutions adaptées et garantit des services sur mesure.<br>
### But de l'application
Le responsable souhaite avoir <strong>un petit utilitaire pour gérer le personnel et leurs absences</strong>.<br>
L'application MediaTek représente cet utilitaire.<br>
L'application doit permettre de :
<ul>
<li>présenter la liste du personnel (nom, prénom, tel, mail, service)</li>
<li>permettre d'ajouter un membre du personnel ;</li>
<li>permettre de modifier ou supprimer un membre du personnel ;</li>
</ul>

### Structure de la BDD
Schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL

### Interface
La fenêtre de l'application

### Diagramme de paquetage
L'application est structurée dans le respect du pattern MVC

#### Explications sur les couches supplémentaires
L'application contient 2 paquetages supplémentaires par rapport au MVC classique :<br>
. 'bddmanager' : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).<br>
. 'dal' (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.<br>
L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le controleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.<br>
Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.<br>
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.
#### Présentation du cheminement
L'application démarre sur une vue : c'est la structure classique des applications C# de bureau, mais il serait aussi possible de démarrer sur un contrôleur principal.<br>
La vue crée une instance du contrôleur qui lui est dédié (chaque vue a son propre contrôleur). Quand elle a besoin d'accéder aux données (affichage ou demande de modifications), elle fait appel à son contrôleur.<br>
Le contrôleur fait appel aux classes de la couche 'dal' pour exécuter les demandes de la vue.<br>
Les classes de la couche 'dal' contiennent les requêtes qui doivent être exécutées et sollicitent la couche 'bddmanager' pour exécuter les requêtes.<br>
Chaque classe de la couche 'dal' est liée à une classe métier contenu dans 'model'. Ces classes correspondent aux tables de la base de données (avec une approche objet, donc pas de clés étrangères mais des références d'objets) et ne contiennent que la structure des données (propriétés, getters, setters).
Excepté 'bddmanager' qui est indépendant de l'application (réutilisable dans n'importe quelle application), toutes les couches exploitent le 'model' (pour le formatage des données).<br>
## Etapes de construction
Les différents commits montrent la création de l'application étape par étape.
### Commit "Phase 1 : Ajout des packages
La structure de l'application est créée (les paquetages et classes), dans le respect du diagramme de paquetage.
L'application n'est pas encore opérationnelle.
### Commit "Phase 2 : Visuel des interfaces"
Mise en place des interfaces graphiques de l’application.
### Commit "Phase 3 : Modèle, outils de connexion et documentation"
Ajout du modèle de données, de la connexion à la base de données ainsi que de la documentation initiale du projet.
### Commit "Phase 4 : Coder les fonctionnalités de l'application (cas d’utilisation)"
Implémentation des principales fonctionnalités de l’application.
### Commit "Phase 5 : Ajout d’un installeur"
Création d’un installateur.

## Installation
Il est possible de tester l'application étape par étape (commit par commit) ou de tester directement la version finale.<br>
Pour tester une version dans un environnement de développement, il faut d'abord installer les outils suivants :<br>
. SGBDR MySQL (par exemple en installant WAMP ou un logiciel similaire)<br>
. De préférence un IDE pour manipuler le code (cette application a été réalisée sous Visual Studio 2022)<br> 
Il faut ensuite :<br>
. Dans MySQL, exécuter le script contenu dans habilitations.sql (présent en racine du dépôt) pour créer et remplir la BDD.<br>
. Récupérer le code du commit voulu, l'ouvrir dans l'IDE et l'exécuter.
