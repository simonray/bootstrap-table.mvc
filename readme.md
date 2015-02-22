#bootstrap-table.mvc (C# / MVC) [![nuget package](https://img.shields.io/nuget/v/bootstrap-table.mvc.png?style=flat-square)](https://www.nuget.org/profiles/simonray)

A fluent Html helper for the popular [bootstrap-table](https://github.com/wenzhixin/bootstrap-table) plug-in.

To install, run the following command in the Package Manager Console.

```csharp
Install-Package bootstrap-table.mvc
```

## Configuration
Add the following css

```css
<link href="~/Content/bootstrap-table.min.css" rel="stylesheet" />
```

and script to your project
```css
<script src="~/Scripts/bootstrap-table/bootstrap-table.min.js"></script>
```
>

## Usage
You're now ready to start using bootstrap-table.

```csharp
@(Html.BootstrapTable<Person>(Url.Action("GetPeoplePaged"), TablePaginationOption.server)
    .Apply(TableOption.striped)
    .Apply(m => m.Id, ColumnOption.align_center))
```

![Alt text](http://s7.postimg.org/eo5ve0ukr/screenshot.png "screenshot")

## Examples
[Download](http://github.com/simonray/bootstrap-table.mvc/zipball/master/)

## Change Log

#### 1.1.1 (22-02-15)
* Set column title as split camel-case.
* Support for ordered model properties [Display(Order=#)].

#### 1.1.0 (19-02-15)
* Simplify interface and options.
* Removed PagingUrl -> constructor (TablePaginationOption.###).
* Upgrade to latest [bootstrap-table](https://github.com/wenzhixin/bootstrap-table).

#### 1.0.1 (22-01-15)
* Upgrade to latest [bootstrap-table](https://github.com/wenzhixin/bootstrap-table).

#### 1.0.0 (16-01-15)
* Initial Release.

## Acknowledgements

* [bootstrap-table](https://github.com/wenzhixin/bootstrap-table) / [documentation](http://bootstrap-table.wenzhixin.net.cn/)
* [startbootstrap.com](http://startbootstrap.com)
