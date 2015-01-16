#bootstrap-table.mvc (ASP.NET / MVC)

A fluent Html helper for the popular [bootstrap-table](https://github.com/wenzhixin/bootstrap-table) plugin.

###Nuget
To install via nuget.
```csharp
Install-Package bootstrap-table.mvc
```
or you can download the [bootstrap-table](https://github.com/wenzhixin/bootstrap-table) plug-in manually.

###Configure
Add the css and script to your page (layout or bundle)

####css
```
<link href="~/Content/bootstrap-table.css" rel="stylesheet" />
```
####script
```
@section scripts
{
    <script src="~/Scripts/bootstrap-table/bootstrap-table.js"></script>
}
```
>

###Implementation

####Data
Setup a model and some controller actions to provide access the data.

#####model
```csharp
public class Person
{
    public int Id { get; set; }
    [Display(Name = "First")]
    public string FirstName { get; set; }
    [Display(Name = "Last")]
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool Active { get; set; }
    [HiddenInput(DisplayValue = false)]
    public string HiddenField1 { get; set; }
    [Display(AutoGenerateField = false)]
    public string HiddenField2 { get; set; }
}
```

#####controller
```csharp
private List<Person> PeopleContext()
{
    return new List<Person>
    {
        new Person { Id = 1, FirstName = "First1", LastName = "Last1", Email = "1@host.com", Active = true, },
        new Person { Id = 2, FirstName = "First2", LastName = "Last2", Email = "2@host.com", Active = true, },
        new Person { Id = 3, FirstName = "First3", LastName = "Last3", Email = "3@host.com", Active = true, },
        ...
    };
}

public JsonResult GetPeopleData()
{
    return Json(PeopleContext(), JsonRequestBehavior.AllowGet);
}

public JsonResult GetPeoplePaged(int offset, int limit, string search, string sort, string order)
{
    var people = PeopleContext();
    var model = new
    {
        total = people.Count(),
        rows = people.Skip((offset / limit) * limit).Take(limit),
    };
    return Json(model, JsonRequestBehavior.AllowGet);
}
```

####View examples

#####simple list
```csharp
@(Html.BootstrapTable(Url.Action("GetPeopleData"))
    .Columns("Id", "FirstName", "LastName", "Email")
)
```

#####columns populated from a view model (supports basic annotations - see model above)
```csharp
@Html.BootstrapTable<Person>(Url.Action("GetPeopleData", "Home"))
```

#####server-side paginated table with custom columns
```csharp
@(Html.BootstrapTable()
    .PagingUrl(Url.Action("GetPeoplePaged"))
    .Column("Id")
    .Column("First Name", "FirstName")
        .ApplyColumn(ColumnOption.align, "right")
    .Column("Last Name", "LastName")
        .ApplyColumn(ColumnOption.align, "right")
)
```

### #source and #sample project (soon!)

<br/>
![Alt text](http://s10.postimg.org/bmawadqgp/bt_sample.png "sample")



###Credits / References

* [bootstrap-table](https://github.com/wenzhixin/bootstrap-table)  
* [documentation](http://bootstrap-table.wenzhixin.net.cn/)

