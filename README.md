# TransportCanada

# Procédure d'installation
Installation du Site web et de l'API 1 pour Windows IIS:
1. Installer ASP.NET Core Runtime 3.1.15 - Windows Hosting Bundle (https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-aspnetcore-3.1.5-windows-hosting-bundle-installer)
2. Exécuter un IISRESET
3. Créer un répertoir ou le site sera hébergé
4. Copier le contenu de API1/TransportCanada/bin/Debug/netcoreapp2.1/publish au dossier créé au point 3
5. Ouvrir IIS
6. Créer un Application Pool nommé NetCore avec un ".NET CLR version" de "No Managed Code"
7. Changer les permissions du dossier créé au point 3 ajouter "IIS AppPool\NetCore" avec la permission Modify
8. Créer un nouveau site ou ajouter un application à un site existant, donner un nom, pointer au dossier créé au point 3, puis choisir l'Application Pool créé au point 6
9. Naviguer au nouveau site

# Hébergement
Hébergement https://thebro.net/tc


# Logiciels et versions requis
ASP.NET Core Runtime 2.1.16 - Windows Hosting Bundle (https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-aspnetcore-3.1.5-windows-hosting-bundle-installer)


# Instruction pour reconstruire les APIs
Le site web et l'API 1 peuvent être reconstruit en ouvrant la Solution API1/TransportCanada.sln. Ensuite faire un clique droit sur le projet TransportCanada et cliquer sur "Publish". S'il n'y a pas déjà un profile de créé, créer un profile "File System" (prendre note du dossier de destination) et garder les paramètres par défault. Cliquer finalement sur "Publish" et copier les fichiers résultant au site IIS.


# Autres informations
Le site web devrait populer le lien pour l'API 1 automatiquement, si non le lien à utiliser est le lien de base du site (ex: https://thebro.net/tc/) suivi de API1/index.

Pour tous les APIs si le champs de recherche contient du texte l'option Visionner et Télécharger seront filtré d'après la valeur dans la boite de recherche.
