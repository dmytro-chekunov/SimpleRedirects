
# Simple301#
### 301 Redirect Manager for Umbraco ###
[![Build status](https://img.shields.io/appveyor/ci/wkallhof/simple301/master.svg)](https://ci.appveyor.com/project/wkallhof/simple301/branch/master)

**Note** This package requires Umbraco v7.3.0-RC+

Simple 301 Redirect Manager is a simple to use, yet extensible, Umbraco 7.3 Back-Office package that allows you to manage your 301 redirects from directly in Umbraco. Includes a simple and intuitive refinement system where you can search for specific text within the URLs or notes defined for the redirect. 

Utilizes [ngTable][ngTableLink] for an AngularJs driven data table which includes ordering by column (Old Url, New Url, Notes and Last Updated) and simple pagination with configurable items per page selector. 

### Getting Started ###

Nuget Package: ` Install-Package Simple301 -Pre `

### Usage ###

#### 1. Locate Simple301 Redirect Manager in the Content section ####
Navigate to the Umbraco > Content section. You will find a 'Manage Redirects' tab in the right pane. Select this to view the Simple301 Redirect Manager. From this window you can view and manage all of the redirects for your site.
![Go to Umbraco > Content > Manage Redirects][locateImage]

#### 2. Refine & Locate ####
Use the provided Text search by entering text in the 'Search redirects' input box. As you type, results will display in real time. Use pagination and the results-per-page selectors to view more or fewer redirects at a time in the table.

![Refine by Text Search, and Pagination][refineImage]

### 3. Add, Update & Delete ###
Use the provided actions in the Action column to Add, Update & Delete existing redirects. Update your redirect in line with the rest of the redirects (make sure to click 'Save') or simply fill out a new redirect at the bottom of the table and click 'Add'. 

![Add, Update & Delete][crudImage]

__Support:__ [Documentation Wiki](https://github.com/wkallhof/Simple301/wiki), [Issue Logging](https://github.com/wkallhof/Simple301/issues)

[ngTableLink]: https://github.com/esvit/ng-table
[highlightJsLink]: https://github.com/isagalaev/highlight.js
[locateImage]: package/Locate.gif  "Locate"
[refineImage]: package/Refine.gif  "Refine"
[crudImage]: package/Crud.gif "Create, Update & Delete"
