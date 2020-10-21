using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models
{
    /// <summary>
    /// The modal popup
    /// </summary>
    public class ModalPopup
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id{ get; set; }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public string Header{ get; set; }

        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        /// <value>
        /// The footer.
        /// </value>
        public string Footer { get; set; }

        /// <summary>
        /// Gets or sets the submit button.
        /// </summary>
        /// <value>
        /// The submit button.
        /// </value>
        public string SubmitButton{ get; set; }

        /// <summary>
        /// Gets or sets the close button.
        /// </summary>
        /// <value>
        /// The close button.
        /// </value>
        public string CloseButton{ get; set; }

        /// <summary>
        /// Gets or sets the partial view.
        /// </summary>
        /// <value>
        /// The partial view.
        /// </value>
        public IActionResult PartialView{ get; set; }
    }
}
