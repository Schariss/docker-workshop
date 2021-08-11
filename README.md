# Ajouter une vérification SonarQube dans la pipeline :

Fichiers à modifier :
- .github\workflows\docker-publish.yml
- myApp\SonarQube.Analysis.xml

## But : 
Vérifier que notre code passe les tests par défaut de Sonarqube en vigueur pour les applications C#.

## Liens utiles "
- https://docs.sonarqube.org/latest/analysis/github-integration/
- https://github.com/SonarSource/sonarqube-quality-gate-action