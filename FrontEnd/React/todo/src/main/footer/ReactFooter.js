import React from 'react';
import './ReactFooter.css';
import 'bootstrap/dist/css/bootstrap.min.css';

export default function ReactFooter() {
  return (
    <div>

<section className='d-flex justify-content-center justify-content-lg-between p-4 border-bottom footerCl'>
        <div className='me-5 d-none d-lg-block'>
          <span>Get connected with me on social networks:</span>
        </div>

        <div>
          <a href='' className='me-4 text-reset'>
          <i className="bi bi-linkedin"></i>
          </a>
          <a href='' className='me-4 text-reset'>
          <i className="bi bi-instagram"></i>
          </a>
          <a href='' className='me-4 text-reset'>
          <i className="bi bi-github"></i>
          </a>
        </div>
      </section>

    </div>
  )
}
