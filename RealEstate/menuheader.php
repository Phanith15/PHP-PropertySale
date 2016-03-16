<div class="headercentre">
  
    <ul class="menu">
        <li style="border-left: 0px solid #121418;"><a href="index.php">Home</a></li>
        <!--<li><a href="index.php?page=forsale">For Sale</a></li>-->
        <li><a href="index.php?page=propertysearch">For Sale</a></li>
        <li><a href="index.php?page=accessories">Accessories</a></li>
        <li><a href="index.php?page=about">About</a></li>
        <li><a href="index.php?page=contact">Contact</a></li>
        <li style="border-right: 0px solid #121418;"><a href="index.php?page=admin">Admin</a></li>
    </ul>
</div>

<script type="text/javascript" src="js/jquery.js"></script>
<script>
   $(function(){// For hilight on current page.
        $('a').each(function(){
           if($(this).prop('href')==window.location.href){
            $(this).addClass('current');
            } 
        });
   });
</script>