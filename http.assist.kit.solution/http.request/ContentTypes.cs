using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace http.request
{
    /// <summary>
    /// 网络请求内容类型(ContentType)枚举
    /// </summary>
    public enum ContentTypes
    {

        /// <summary>
        /// application/json
        /// </summary>
        [Description("application/json")]
        JSON,

        /// <summary>
        /// application/x-www-form-urlencoded
        /// </summary>
        [Description("application/x-www-form-urlencoded")]
        X_WWW_FORM_URLENCODED,

        /// <summary>
        /// application/msword
        /// </summary>
        [Description("application/msword")]
        DOC,

        /// <summary>
        /// application/octet-stream
        /// </summary>
        [Description("application/octet-stream")]
        BIN,

        /// <summary>
        /// application/octet-stream
        /// </summary>
        [Description("application/octet-stream")]
        EXE,

        /// <summary>
        /// application/octet-stream
        /// </summary>
        [Description("application/octet-stream")]
        CLASS,

        /// <summary>
        /// application/octet-stream
        /// </summary>
        [Description("application/octet-stream")]
        DLL,

        /// <summary>
        /// application/pdf
        /// </summary>
        [Description("application/pdf")]
        PDF,

        /// <summary>
        /// application/vnd.ms-excel
        /// </summary>
        [Description("application/vnd.ms-excel")]
        XLS,

        /// <summary>
        /// application/vnd.ms-powerpoint
        /// </summary>
        [Description("application/vnd.ms-powerpoint")]
        PPT,

        /// <summary>
        /// video/x-sgi-movie
        /// </summary>
        [Description("video/x-sgi-movie")]
        MOVIE,

        /// <summary>
        /// video/x-msvideo
        /// </summary>
        [Description("video/x-msvideo")]
        AVI,

        /// <summary>
        /// video/vnd.mpegurl
        /// </summary>
        [Description("video/vnd.mpegurl")]
        MXU,

        /// <summary>
        /// video/quicktime
        /// </summary>
        [Description("video/quicktime")]
        MOV,

        /// <summary>
        /// video/quicktime
        /// </summary>
        [Description("video/quicktime")]
        QT,

        /// <summary>
        /// video/mpeg
        /// </summary>
        [Description("video/mpeg")]
        MPE,

        /// <summary>
        /// video/mpeg
        /// </summary>
        [Description("video/mpeg")]
        MPG,

        /// <summary>
        /// video/mpeg
        /// </summary>
        [Description("video/mpeg")]
        MPEG,

        /// <summary>
        /// text/xml
        /// </summary>
        [Description("text/xml")]
        XML,

        /// <summary>
        /// text/xml
        /// </summary>
        [Description("text/xml")]
        XSL,

        /// <summary>
        /// text/x-setext
        /// </summary>
        [Description("text/x-setext")]
        ETX,

        /// <summary>
        /// text/vnd.wap.wmlscript
        /// </summary>
        [Description("text/vnd.wap.wmlscript")]
        WMLS,

        /// <summary>
        /// text/vnd.wap.wml
        /// </summary>
        [Description("text/vnd.wap.wml")]
        WML,

        /// <summary>
        /// text/tab-separated-values
        /// </summary>
        [Description("text/tab-separated-values")]
        TSV,

        /// <summary>
        /// text/sgml
        /// </summary>
        [Description("text/sgml")]
        SGM,

        /// <summary>
        /// text/sgml
        /// </summary>
        [Description("text/sgml")]
        SGML,

        /// <summary>
        /// text/rtf
        /// </summary>
        [Description("text/rtf")]
        RTF,

        /// <summary>
        /// text/richtext
        /// </summary>
        [Description("text/richtext")]
        RTX,

        /// <summary>
        /// text/plain
        /// </summary>
        [Description("text/plain")]
        TXT,

        /// <summary>
        /// text/plain
        /// </summary>
        [Description("text/plain")]
        ASC,

        /// <summary>
        /// text/html
        /// </summary>
        [Description("text/html")]
        HTML,

        /// <summary>
        /// text/html
        /// </summary>
        [Description("text/html")]
        HTM,

        /// <summary>
        /// text/css
        /// </summary>
        [Description("text/css")]
        CSS,

        /// <summary>
        /// model/vrml
        /// </summary>
        [Description("model/vrml")]
        VRML,

        /// <summary>
        /// model/vrml
        /// </summary>
        [Description("model/vrml")]
        WRL,

        /// <summary>
        /// model/mesh
        /// </summary>
        [Description("model/mesh")]
        SILO,

        /// <summary>
        /// model/mesh
        /// </summary>
        [Description("model/mesh")]
        MESH,

        /// <summary>
        /// model/mesh
        /// </summary>
        [Description("model/mesh")]
        MSH,

        /// <summary>
        /// model/iges
        /// </summary>
        [Description("model/iges")]
        IGES,

        /// <summary>
        /// model/iges
        /// </summary>
        [Description("model/iges")]
        IGS,

        /// <summary>
        /// image/x-xwindowdump
        /// </summary>
        [Description("image/x-xwindowdump")]
        XWD,

        /// <summary>
        /// image/x-xpixmap
        /// </summary>
        [Description("image/x-xpixmap")]
        XPM,

        /// <summary>
        /// image/x-xbitmap
        /// </summary>
        [Description("image/x-xbitmap")]
        XBM,

        /// <summary>
        /// image/x-rgb
        /// </summary>
        [Description("image/x-rgb")]
        RGB,

        /// <summary>
        /// image/x-portable-pixmap
        /// </summary>
        [Description("image/x-portable-pixmap")]
        PPM,

        /// <summary>
        /// image/x-portable-graymap
        /// </summary>
        [Description("image/x-portable-graymap")]
        PGM,

        /// <summary>
        /// image/x-portable-bitmap
        /// </summary>
        [Description("image/x-portable-bitmap")]
        PBM,

        /// <summary>
        /// image/x-portable-anymap
        /// </summary>
        [Description("image/x-portable-anymap")]
        PNM,

        /// <summary>
        /// image/x-cmu-raster
        /// </summary>
        [Description("image/x-cmu-raster")]
        RAS,

        /// <summary>
        /// image/vnd.wap.wbmp
        /// </summary>
        [Description("image/vnd.wap.wbmp")]
        WBMP,

        /// <summary>
        /// image/vnd.djvu
        /// </summary>
        [Description("image/vnd.djvu")]
        DJV,

        /// <summary>
        /// image/vnd.djvu
        /// </summary>
        [Description("image/vnd.djvu")]
        DJVU,

        /// <summary>
        /// image/tiff
        /// </summary>
        [Description("image/tiff")]
        TIF,

        /// <summary>
        /// image/tiff
        /// </summary>
        [Description("image/tiff")]
        TIFF,

        /// <summary>
        /// image/png
        /// </summary>
        [Description("image/png")]
        PNG,

        /// <summary>
        /// image/jpeg
        /// </summary>
        [Description("image/jpeg")]
        JPE,

        /// <summary>
        /// image/jpeg
        /// </summary>
        [Description("image/jpeg")]
        JPG,

        /// <summary>
        /// image/jpeg
        /// </summary>
        [Description("image/jpeg")]
        JPEG,

        /// <summary>
        /// image/ief
        /// </summary>
        [Description("image/ief")]
        IEF,

        /// <summary>
        /// image/gif
        /// </summary>
        [Description("image/gif")]
        GIF,

        /// <summary>
        /// image/bmp
        /// </summary>
        [Description("image/bmp")]
        BMP,

        /// <summary>
        /// chemical/x-xyz
        /// </summary>
        [Description("chemical/x-xyz")]
        XYZ,

        /// <summary>
        /// chemical/x-pdb
        /// </summary>
        [Description("chemical/x-pdb")]
        PDB,

        /// <summary>
        /// audio/x-wav
        /// </summary>
        [Description("audio/x-wav")]
        WAV,

        /// <summary>
        /// audio/x-realaudio
        /// </summary>
        [Description("audio/x-realaudio")]
        RA,

        /// <summary>
        /// audio/x-pn-realaudio-plugin
        /// </summary>
        [Description("audio/x-pn-realaudio-plugin")]
        RPM,

        /// <summary>
        /// audio/x-pn-realaudio
        /// </summary>
        [Description("audio/x-pn-realaudio")]
        RM,

        /// <summary>
        /// audio/x-pn-realaudio
        /// </summary>
        [Description("audio/x-pn-realaudio")]
        RAM,

        /// <summary>
        /// audio/x-mpegurl
        /// </summary>
        [Description("audio/x-mpegurl")]
        M3U,

        /// <summary>
        /// audio/x-aiff
        /// </summary>
        [Description("audio/x-aiff")]
        AIFC,

        /// <summary>
        /// audio/x-aiff
        /// </summary>
        [Description("audio/x-aiff")]
        AIFF,

        /// <summary>
        /// audio/x-aiff
        /// </summary>
        [Description("audio/x-aiff")]
        AIF,

        /// <summary>
        /// audio/mpeg
        /// </summary>
        [Description("audio/mpeg")]
        MP3,

        /// <summary>
        /// audio/mpeg
        /// </summary>
        [Description("audio/mpeg")]
        MP2,

        /// <summary>
        /// audio/mpeg
        /// </summary>
        [Description("audio/mpeg")]
        MPGA,

        /// <summary>
        /// audio/midi
        /// </summary>
        [Description("audio/midi")]
        KAR,

        /// <summary>
        /// audio/midi
        /// </summary>
        [Description("audio/midi")]
        MIDI,

        /// <summary>
        /// audio/midi
        /// </summary>
        [Description("audio/midi")]
        MID,

        /// <summary>
        /// audio/basic
        /// </summary>
        [Description("audio/basic")]
        SND,

        /// <summary>
        /// audio/basic
        /// </summary>
        [Description("audio/basic")]
        AU,

        /// <summary>
        /// application/zip
        /// </summary>
        [Description("application/zip")]
        ZIP,

        /// <summary>
        /// application/xhtml+xml
        /// </summary>
        [Description("application/xhtml+xml")]
        XHT,

        /// <summary>
        /// application/xhtml+xml
        /// </summary>
        [Description("application/xhtml+xml")]
        XHTML,

        /// <summary>
        /// application/x-wais-source
        /// </summary>
        [Description("application/x-wais-source")]
        SRC,

        /// <summary>
        /// application/x-ustar
        /// </summary>
        [Description("application/x-ustar")]
        USTAR,

        /// <summary>
        /// application/x-troff-ms
        /// </summary>
        [Description("application/x-troff-ms")]
        MS,

        /// <summary>
        /// application/x-troff-me
        /// </summary>
        [Description("application/x-troff-me")]
        ME,

        /// <summary>
        /// application/x-troff-man
        /// </summary>
        [Description("application/x-troff-man")]
        MAN,

        /// <summary>
        /// application/x-troff
        /// </summary>
        [Description("application/x-troff")]
        ROFF,

        /// <summary>
        /// application/x-troff
        /// </summary>
        [Description("application/x-troff")]
        TR,

        /// <summary>
        /// application/x-troff
        /// </summary>
        [Description("application/x-troff")]
        T,

        /// <summary>
        /// application/x-texinfo
        /// </summary>
        [Description("application/x-texinfo")]
        TEXI,

        /// <summary>
        /// application/x-texinfo
        /// </summary>
        [Description("application/x-texinfo")]
        TEXINFO,

        /// <summary>
        /// application/x-tex
        /// </summary>
        [Description("application/x-tex")]
        TEX,

        /// <summary>
        /// application/x-tcl
        /// </summary>
        [Description("application/x-tcl")]
        TCL,

        /// <summary>
        /// application/x-tar
        /// </summary>
        [Description("application/x-tar")]
        TAR,

        /// <summary>
        /// application/x-sv4crc
        /// </summary>
        [Description("application/x-sv4crc")]
        SV4CRC,

        /// <summary>
        /// application/x-sv4cpio
        /// </summary>
        [Description("application/x-sv4cpio")]
        SV4CPIO,

        /// <summary>
        /// application/x-stuffit
        /// </summary>
        [Description("application/x-stuffit")]
        SIT,

        /// <summary>
        /// application/x-shockwave-flash
        /// </summary>
        [Description("application/x-shockwave-flash")]
        SWF,

        /// <summary>
        /// application/x-shar
        /// </summary>
        [Description("application/x-shar")]
        SHAR,

        /// <summary>
        /// application/x-sh
        /// </summary>
        [Description("application/x-sh")]
        SH,

        /// <summary>
        /// application/x-netcdf
        /// </summary>
        [Description("application/x-netcdf")]
        CDF,

        /// <summary>
        /// application/x-netcdf
        /// </summary>
        [Description("application/x-netcdf")]
        NC,

        /// <summary>
        /// application/x-latex
        /// </summary>
        [Description("application/x-latex")]
        LATEX,

        /// <summary>
        /// application/x-koan
        /// </summary>
        [Description("application/x-koan")]
        SKM,

        /// <summary>
        /// application/x-koan
        /// </summary>
        [Description("application/x-koan")]
        SKT,

        /// <summary>
        /// application/x-koan
        /// </summary>
        [Description("application/x-koan")]
        SKD,

        /// <summary>
        /// application/x-koan
        /// </summary>
        [Description("application/x-koan")]
        SKP,

        /// <summary>
        /// application/x-javascript
        /// </summary>
        [Description("application/x-javascript")]
        JS,

        /// <summary>
        /// application/x-hdf
        /// </summary>
        [Description("application/x-hdf")]
        HDF,

        /// <summary>
        /// application/x-gtar
        /// </summary>
        [Description("application/x-gtar")]
        GTAR,

        /// <summary>
        /// application/x-futuresplash
        /// </summary>
        [Description("application/x-futuresplash")]
        SPL,

        /// <summary>
        /// application/x-dvi
        /// </summary>
        [Description("application/x-dvi")]
        DVI,

        /// <summary>
        /// application/x-director
        /// </summary>
        [Description("application/x-director")]
        DXR,

        /// <summary>
        /// application/x-director
        /// </summary>
        [Description("application/x-director")]
        DIR,

        /// <summary>
        /// application/x-director
        /// </summary>
        [Description("application/x-director")]
        DCR,

        /// <summary>
        /// application/x-csh
        /// </summary>
        [Description("application/x-csh")]
        CSH,

        /// <summary>
        /// application/x-cpio
        /// </summary>
        [Description("application/x-cpio")]
        CPIO,

        /// <summary>
        /// application/x-chess-pgn
        /// </summary>
        [Description("application/x-chess-pgn")]
        PGN
    }
}
