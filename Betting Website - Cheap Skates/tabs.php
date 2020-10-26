<?php
    $tabs = array();
    function tabs_header() {
    ?>
<style type="text/css">
a {
    text-decoration:none;
color:#000000;
}
.tab {
    border-bottom: 2px solid #f1f1f1;
    text-align: center;
    font-family: Verdana;}

.tab-active {
    border-left: 2px solid #f1f1f1;
    border-top: 2px solid #f1f1f1;
    border-right: 2px solid #f1f1f1;
    text-align: center;
    font-family: Verdana;
    font-weight: bold;}

.tab-content {
padding: 5px;
    border-left: 2px solid #f1f1f1;
    border-right: 2px solid #f1f1f1;
    border-bottom: 2px solid #f1f1f1;}
    
    </style>
    <?php
}

function tabs_start() {
    ob_start();
}

function endtab() {
    global $tabs;
    $text = ob_get_clean();
    $tabs[ count( $tabs ) - 1 ][ 'text' ] = $text;
    ob_start();
}

function tab($title) {
    global $tabs;
    
    if ( count( $tabs ) > 0 ) {
        endtab();
    }
    $tabs []= array(
                    title => $title,
                    text => ""
                    );
}

function tabs_end() {
    global $tabs;
    endtab( );
    ob_end_clean( );
    $index = 0;
    if ($_GET['tabindex']) {
        $index = $_GET['tabindex'];
    }
    
    ?>
    <table width="100%" cellspacing="0" cellpadding="0">
    <tr>
    <?php
    $baseuri = $_SERVER['REQUEST_URI'];
    $baseuri = preg_replace( "/\?.*$/", "", $baseuri );
    $curindex = 0;
    foreach($tabs as $tab) {
        $class = "tab";
        if ( $index == $curindex ) {
            $class ="tab-active";
        }
        ?>
        <td class="<?php echo($class); ?>">
        <a href="<?php echo( $baseuri."?tabindex=".$curindex ); ?>">
        <?php echo( $tab['title'] ); ?>
        </a>
        </td>
        <?php
        $curindex += 1;
    }
    ?>
    </tr>
    <tr><td class="tab-content" colspan="<?php echo( count( $tabs ) + 1 ); ?>">
    <?php echo( $tabs[$index ]['text'] ); ?>
    </td></tr>
    </table>
    <?php
}
?>
