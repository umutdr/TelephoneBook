$(() => {
  let searchInput = $('#searchInput');
  let tableDataHere = $('#tabledatahere');

  $('#dataTable2').DataTable({
    order: [] // auto ordering off
  });

  searchInput.autocomplete({
    source: (req, res) => {
      $.ajax({
        url: '/Home/GetSearchValue',
        type: 'GET',
        dataType: 'json',
        data: {
          searchValue: searchInput.val()
        },
        success: data => {
          if (data.length === 0) {
            tableDataHere.html(`
            <tr>
                <td align='center' colspan='5' class='btn-outline-warning'>No Data</td>
            </tr>
          `);
          }
          res(
            $.map(data, item => {
              return {
                label: `${item.Name} ${item.Surname}, ${item.Role} / ${item.Department} `,
                value: item.Id
              };
            })
          );
        },
        error: (xhr, status, error) => {
          alert('Error:' + error + '\nStatus:' + status + '\nxhr:' + xhr);
        }
      });
    },
    minLength: 3,
    maxShowItems: 15, // Jquery.Ui.Scroll.js
    select: function(e, i) {
      let itemValue = i.item.value;
      i.item.value = i.item.label;

      $.ajax({
        url: '/Home/GetPersonnelById',
        type: 'GET',
        dataType: 'json',
        data: {
          personnelId: itemValue
        },
        success: data => {
          tableDataHere.html(`
                    <tr>
                        <td>${data['Name']}</td>
                        <td>${data['Surname']}</td>
                        <td>${data['Role']}</td>
                        <td>${data['Department']}</td>
                        <td>${data['Phone']}</td>
                    </tr>
                  `);
        },
        error: (xhr, status, error) => {
          alert('Error:' + error + '\nStatus:' + status + '\nxhr:' + xhr);
        }
      });
    }
  });

  $('#clearbtn').on('click', () => {
    searchInput.val('');
  });

  //   $('.ui-autocomplete').attr('onmouseup', 'console.log("heyy");');

  //   searchInput.bind('autocompleteselect', function(event, ui) {
  //     console.log("heyy");
  //   });
});
